  using System;
  using System.Collections.Generic;
  using System.IO;

  class csvReader
  {
      static void CsvFolder()
      {
          string filePath = "2016_coco_emissions.csv";
          List<string> countries;
          List<string> emissionTypes;
          int[,] data = ReadCsv(filePath, out countries, out emissionTypes);

          // Display the data
          DisplayData(data, countries, emissionTypes);


          filePath = "2018_coco_emissions.csv";
          data = ReadCsv(filePath, out countries, out emissionTypes);

          // Display the data
          DisplayData(data, countries, emissionTypes);

        filePath = "2019_coco_emissions.csv";
        data = ReadCsv(filePath, out countries, out emissionTypes);

        // Display the data
        DisplayData(data, countries, emissionTypes);


        filePath = "2020_coco_emissions.csv";
        data = ReadCsv(filePath, out countries, out emissionTypes);

        // Display the data
        DisplayData(data, countries, emissionTypes);

        filePath = "2021_coco_emissions.csv";
        data = ReadCsv(filePath, out countries, out emissionTypes);

        // Display the data
        DisplayData(data, countries, emissionTypes);

        filePath = "2022_coco_emissions.csv";
        data = ReadCsv(filePath, out countries, out emissionTypes);

        // Display the data
        DisplayData(data, countries, emissionTypes);



      }

      static int[,] ReadCsv(string filePath, out List<string> countries, out List<string> emissionTypes)
      {
          string[] lines = File.ReadAllLines(filePath);

          // Extract country names from the first line
          countries = new List<string>(lines[0].Split(','));

          // Extract emission types from the first column
          emissionTypes = new List<string>();
          for (int i = 1; i < lines.Length; i++)
          {
              string[] fields = lines[i].Split('\t');
              emissionTypes.Add(fields[0]);
          }

          int numRows = emissionTypes.Count;
          int numCols = countries.Count;

          int[,] data = new int[numRows, numCols];

          for (int i = 1; i < lines.Length; i++)
          {
              string[] fields = lines[i].Split('\t');

              for (int j = 1; j < fields.Length; j++)
              {
                  int value;
                  if (int.TryParse(fields[j], out value))
                  {
                      data[i - 1, j - 1] = value;
                  }
                  else
                  {
                      // Handle parsing error (for non-integer values)
                      Console.WriteLine($"Error parsing value at row {i}, column {j + 1}: {fields[j]}");
                  }
              }
          }

          return data;
      }

      static void DisplayData(int[,] data, List<string> countries, List<string> emissionTypes)
      {
          Console.Write("\t"); // Placeholder for the top-left cell
          foreach (var country in countries)
          {
              Console.Write($"{country}\t");
          }
          Console.WriteLine();

          for (int i = 0; i < data.GetLength(0); i++)
          {
              Console.Write($"{emissionTypes[i]}\t");
              for (int j = 0; j < data.GetLength(1); j++)
              {
                  Console.Write($"{data[i, j]}\t");
              }
              Console.WriteLine();
          }

        }
      }
