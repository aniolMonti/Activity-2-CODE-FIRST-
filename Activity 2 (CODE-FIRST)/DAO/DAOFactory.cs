﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2__CODE_FIRST_.DAO
{
    public class DAOFactory
    {
        public static IDAOManager GetDAOManager()
        {
            return new DAOManager();
        }
    }
}
