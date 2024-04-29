using LoginJALA.Migrations;

namespace LoginJALA.Services.Interface_
{
    public interface ILogin
    {
        LoginDetails LoginCheck(string username,string password);
    }
}
