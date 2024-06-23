﻿using API_Test.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Test.FullResponseDataModels;

public class StarshipFullDataModel : IFullDataModel
{
    public int count { get; set; }
    public string next { get; set; }
    public string previous { get; set; }
    public List<IDataModel> results { get; set; }
    public string ResponseName { get => "starships"; }
}