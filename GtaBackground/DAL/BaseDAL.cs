using System.Configuration;
namespace GtaBackground.DAL
{
    public abstract class BaseDAL
    {
        protected readonly DapperUtil _dapperUtil;
        protected readonly string _dbConnectionString;

        public BaseDAL()
        {
            _dbConnectionString = "server=192.168.1.80;uid=szjson_user;pwd=87@8DA7C3;database=GTADB";
            _dapperUtil = new DapperUtil(_dbConnectionString);
        }
    }
}
