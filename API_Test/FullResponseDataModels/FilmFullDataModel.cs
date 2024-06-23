﻿using API_Test.DataModels;

namespace API_Test.FullResponseDataModels;

public class FilmFullDataModel : IFullDataModel
{
    public int count { get; set; }
    public string next { get; set; }
    public string previous { get; set; }
    public List<FilmDataModel> results { get; set; }

    public void RecordResults()
    {
        throw new NotImplementedException();
    }
}
