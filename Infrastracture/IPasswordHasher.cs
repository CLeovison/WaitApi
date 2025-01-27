namespace WaitApi.Infrastracture;


public interface IPasswordHasher{
    string Hash(string password);

}