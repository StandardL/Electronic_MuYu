using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Electronic_MuYu.Services;

/// <summary>
/// 本代码文件是用于实现沙盒保存功德数据的服务
/// Provide GongDe Out-Of-Box-Experience Services
/// </summary>

class GongDeNumsOOBE
{
    // 获取当前应用的沙盒路径
    static readonly StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
    static readonly string fileName = "GongDeFile.txt";

    // 写入到沙盒文件
    public static async void WriteGongDe(string GongDeNums)
    {
        // 创建文件，如果文件已存在则替换它
        StorageFile outputFile = await localFolder.CreateFileAsync(fileName,
            CreationCollisionOption.ReplaceExisting);
        // 将功德数据写入到文件中
        await FileIO.WriteTextAsync(outputFile, GongDeNums); 
    }

    // 从沙盒文件中读取总功德
    public static async Task<string> ReadGongDe(string GongDeNums)
    {
        try
        {
            // 尝试读取文件
            StorageFile storageFile = await localFolder.GetFileAsync(fileName);
            var gongdeData = await FileIO.ReadTextAsync(storageFile);
            GongDeNums = gongdeData;
            await Task.CompletedTask;
            return GongDeNums;
        }
        catch (FileNotFoundException e)
        {
            Debug.WriteLine("功德文件打开失败！错误信息：{0}", e);
            // 读取失败的时候返回Fail
            GongDeNums = "FAILED";
            await Task.CompletedTask;
            return GongDeNums;
        }
        catch (IOException e)
        {
            // Get information from the exception, then throw
            // the info to the parent method.
            if (e.Source != null)
            {
                Debug.WriteLine("IOException source: {0}", e.Source);
            }
            throw;
        }
        return GongDeNums.ToString();
    }
}
