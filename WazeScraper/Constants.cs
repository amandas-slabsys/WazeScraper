﻿namespace WazeScraper
{
    public class Constants
    {
        #region Request Header
        public const string WazeHost = "www.waze.com";
        public const string DefaultUserAgent = "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:43.0) Gecko/20100101 Firefox/43.0";
        public const string DefaultHeaderAccept = "*/*";
        public const string DefaultXRequestedWith = "XMLHttpRequest";
        public const string DefaultReferer = "https://www.waze.com/livemap";
        #endregion

        #region URL
        public const string URL_Start = "https://www.waze.com/row-rtserver/web/TGeoRSS?";
        public const string URL_Type = "&types=alerts";
        public const int MaxAlerts = 800;
        #endregion

        #region Coordinates for LT search
        public const int x_start = 53;
        public const int x_end = 56;
        public const int y_start = 20;
        public const int y_end = 27;
        public const string SearchedType = "POLICE";
        public const string CountryCode = "LH";
        #endregion

        #region SQL
        public const string ConnectionStringFormat = @"server={0};userid={1};password={2};database={3}";
        public const string InsertQuery = "INSERT INTO `LT-police` (id, X, Y, Country, City, ReportRating, Confidence, Reliability, subtype, published) VALUES";
        public const string OnDuplicateQuery = "ON DUPLICATE KEY UPDATE ReportRating=values(ReportRating), Confidence=values(Confidence), Reliability=values(Reliability)";

        public const string ConnectionIpKey = "ScraperIp";
        public const string ConnectionPasswordKey = "ScraperPassword";
        public const string ConnectionUserKey = "ScraperUser";
        public const string ConnectionDatabaseKey = "ScraperDatabase";

        #endregion

    }
}
