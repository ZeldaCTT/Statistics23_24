using System;
using System.IO;
using System.Threading.Tasks.Dataflow;
using System.Windows.Markup;
 
class Program
{
    static void Main(){
        string path = "Professional Life - Sheet1.tsv";
        string[,] matrix = tsvToMatrix(path);
 
        // Qualitative variable for example Main hobbies
        string[] hobbiesArray = getColumn(matrix,"Main hobbies");
         
        //Dictionary used to count the frequency of the choosen variable
        Dictionary<string, float> hobbiesDictionary = new Dictionary<string, float>();
        foreach (string i in hobbiesArray){
            string item = i.ToLower();
            if (hobbiesDictionary.ContainsKey(item)){
                hobbiesDictionary[item]++;
            } else {
                hobbiesDictionary[item] = 1;
            }
        }
 
         
        printFrequency(hobbiesDictionary, hobbiesArray.Length,2);
 
 
        // Quantitative discrete for example Age
        string[] ageArray = getColumn(matrix,"Age");
 
        Dictionary<string, float> ageDictionary = new Dictionary<string, float>();
        foreach (string i in ageArray){
            string item = i.ToLower();
            if (ageDictionary.ContainsKey(item)){
                ageDictionary[item]++;
            } else {
                ageDictionary[item] = 1;
            }
        }
         
        printFrequency(ageDictionary, ageArray.Length,0);
         
        // Quantitative continuous for example weight
        string[] weightArray = getColumn(matrix,"weight");
         
        Dictionary<string, float> weightDictionary = new Dictionary<string, float>();
        weightDictionary.Add("50-", 0);
        weightDictionary.Add("[50;60)", 0);
        weightDictionary.Add("[60;70)", 0);
        weightDictionary.Add("[70;80)", 0);
        weightDictionary.Add("80+", 0);
 
        int weightUnits = 0;
 
        foreach (string i in weightArray){
            string item = i.ToLower();
            if(item.Length != 0){
                weightUnits++;
                int w = int.Parse(item);
                if (w < 50) {
                    weightDictionary["50-"] += 1;
                } else if (w >= 50 && w < 60) {
                    weightDictionary["[50;60)"] += 1;
                } else if (w >= 60 && w < 70) {
                    weightDictionary["[60;70)"] += 1;
                } else if (w >= 70 && w < 80) {
                    weightDictionary["[70;80)"] += 1;
                } else if (w >= 80) {
                    weightDictionary["80+"] += 1;
                }
            }
        }
 
        printFrequency(weightDictionary, weightArray.Length,1);
 
        
        //printMatrix(jointBivariate(matrix,"Ambitious (0-5)","Sex"));
         
    }
 
    //Return a matrix from a Tsv file located at path
    public static string[,] tsvToMatrix(string path){
        string[] lines = File.ReadAllLines(path);
 
        int numRows = lines.Length;
        int numCols = lines[0].Split('\t').Length;
 
        string[,] matrix = new string[numRows, numCols];
        for(int i = 0; i < numRows; i++){
            string[] splits = lines[i].Split('\t');
             
            for(int j = 0; j < numCols; j++){
                matrix[i,j] = splits[j];
            }
        }
        return matrix;
    }
 
    //Return only the values of a selected column columname from a matrix 
    public static string[] getColumn(string[,] matrix, string columname){ 
        string[] column = new string[matrix.GetLength(0)-1];
        
        for (int j = 0; j < matrix.GetLength(1); j++){
           if (matrix[0, j] == columname){
            for (int i = 1; i < matrix.GetLength(0); i++){
                column[i-1] = matrix[i, j];
            }
            break; 
            }
        }
        return column;
    }
 
    //Print the values of a column
    public static void printColumn(string[] column){
        foreach(var values in column){
            Console.WriteLine(values);
        }
    }
 
    //print frequency from a dictionary, in a specified mode: 1 for absolute, 2 for relative, other value for percentage
    public static void printFrequency(Dictionary<string, float> dictionary,int len, int mode){
        Console.WriteLine("");
        foreach (var kvp in dictionary){
            if(mode == 0){
                Console.WriteLine($"Key: {kvp.Key} ---> Absolute frequency: {kvp.Value}");
            }
            else if(mode == 1){
                Console.WriteLine($"Key: {kvp.Key} ---> Relative frequency: {kvp.Value/len}");
            }
            else Console.WriteLine($"Key: {kvp.Key} ---> Percentage frequency: {(kvp.Value/len)*100}%");
             
        }
    }
     
    //print the jointBivariate values between two specified varaible
    public static string[,] jointBivariate(string[,] matrix,string variable1, string variable2){
        
        string[] column = getColumn(matrix,variable1);
        string[] row = getColumn(matrix,variable2);
        string[] uniqueColumnValues = column.Distinct().ToArray();
        string[] uniqueRowValues = row.Distinct().ToArray();
        //int[] counter = new int[uniqueColumnValues.Length * uniqueRowValues.Length];        
 
        string[,] matrix2 = new string[uniqueRowValues.Length+1,uniqueColumnValues.Length+1];
        //string truncated1 = variable1.Length <= 3 ? variable1 : variable1.Substring(0, 3);
        //string truncated2 = variable2.Length <= 3 ? variable2 : variable2.Substring(0, 3);
        matrix2[0,0] = "-";
 
        for(int i = 0; i < uniqueColumnValues.Length; i++){
           matrix2[0,i+1] = uniqueRowValues[i];
        }
 
        for(int j = 0; j < uniqueRowValues.Length; j++){
           matrix2[j+1,0] = uniqueColumnValues[j];
        }
     
        for(int i = 0; i < uniqueRowValues.Length; i++){
            for(int j = 0; j < uniqueColumnValues.Length; j++){
                matrix2[i+1,j+1] = "values";
            }
        }  
        return matrix2;
    } 
 
    //print a matrix
    public static void printMatrix(string[,] matrix){
        for (int row = 0; row < matrix.GetLength(0); row++){
            for (int col = 0; col < matrix.GetLength(1); col++){
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
 
    
}