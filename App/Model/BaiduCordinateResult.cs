﻿using System.Collections.Generic;

namespace ESMonitor.Model
{
    public class BaiduCordinateResult
    {
        public int status { get; set; }

        public List<ResultCor> result { get; set; }
    }

    public class ResultCor
    {
        public string x { get; set; }

        public string y { get; set; }
    }
}
