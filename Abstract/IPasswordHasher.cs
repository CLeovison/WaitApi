namespace WaitApi.Abstract;


public interface IPasswordHasher{
    string Hash(string password);

}