//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.Json;
//using CsvHelper;
//using CsvHelper.Configuration;
//using System.Globalization;
//using System.Formats.Asn1;

//class IPLCensorshipAnalyzer
//{
//    static void Main(string[] args)
//    {
//        string jsonInputFile = "ipl_data.json";
//        string csvInputFile = "ipl_data.csv";

//        string jsonOutputFile = "censored_ipl_data.json";
//        string csvOutputFile = "censored_ipl_data.csv";

//        if (File.Exists(jsonInputFile))
//        {
//            string jsonData = File.ReadAllText(jsonInputFile);
//            List<IPLMatch> matches = JsonSerializer.Deserialize<List<IPLMatch>>(jsonData);
//            ProcessMatches(matches);
//            string censoredJson = JsonSerializer.Serialize(matches, new JsonSerializerOptions { WriteIndented = true });
//            File.WriteAllText(jsonOutputFile, censoredJson);
//            Console.WriteLine($" Censored JSON saved to {jsonOutputFile}");
//        }

//        if (File.Exists(csvInputFile))
//        {
//            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true };
//            using var reader = new StreamReader(csvInputFile);
//            using var csv = new CsvReader(reader, config);
//            var matches = csv.GetRecords<IPLMatch>().ToList();

//            ProcessMatches(matches);

//            using var writer = new StreamWriter(csvOutputFile);
//            using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
//            csvWriter.WriteRecords(matches);
//            Console.WriteLine($" Censored CSV saved to {csvOutputFile}");
//        }
//    }

//    static void ProcessMatches(List<IPLMatch> matches)
//    {
//        foreach (var match in matches)
//        {
//            match.Team1 = MaskTeamName(match.Team1);
//            match.Team2 = MaskTeamName(match.Team2);
//            match.PlayerOfTheMatch = "REDACTED";
//        }
//    }

//    static string MaskTeamName(string teamName)
//    {
//        if (string.IsNullOrEmpty(teamName)) return teamName;
//        var parts = teamName.Split(' ');
//        return parts.Length > 1 ? $"{parts[0]} ***" : teamName;
//    }
//}

//class IPLMatch
//{
//    public string Team1 { get; set; }
//    public string Team2 { get; set; }
//    public string PlayerOfTheMatch { get; set; }
//}
