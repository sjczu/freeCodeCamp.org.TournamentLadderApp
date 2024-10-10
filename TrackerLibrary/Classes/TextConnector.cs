﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.Interfaces;

namespace TrackerLibrary.Classes
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the file.
        /// <summary>
        /// Saves new prize to the file.
        /// </summary>
        /// <param name="model">Information about prize.</param>
        /// <returns>Prize information, including unique id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
