using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.Interfaces;
using System.Data;
using Dapper;

/*@name nvarchar(50),
	@type nvarchar(50),
	@amount float,
	@percentage float,
	@place int,
	@id int = 0 output*/

namespace TrackerLibrary.Classes
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves new prize to the database.
        /// </summary>
        /// <param name="model">Information about prize.</param>
        /// <returns>Prize information, including unique id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("TTP")))
            {
                var p = new DynamicParameters();
                p.Add("@name", model.PrizeName);
                p.Add("@type", model.PrizeType);
                p.Add("@amount", model.PrizeAmount);
                p.Add("@percentage", model.PrizePercentage);
                p.Add("@place", model.PlaceNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
