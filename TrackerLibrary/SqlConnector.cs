using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - lam cho phuong thuc CreatePrize thuc su luu vao db
        /// <summary>
        /// save the new prize to the db
        /// </summary>
        /// <param name="model">the prize information</param>
        /// <returns>the prize inf, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
