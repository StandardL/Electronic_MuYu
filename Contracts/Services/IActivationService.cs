namespace Electronic_MuYu.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
