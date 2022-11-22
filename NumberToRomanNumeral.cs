public class convertNumberToRomain{
    public static void Main(string[] args) {
        int valueToConvert;
        int subTotal;
        string result = "";

        // check we get given an actual number
        bool isParsable = int.TryParse(args[0],out valueToConvert);
        if (isParsable) {
                // Set the subtotal
                subTotal = valueToConvert;

                // Get translation dictionary
                Dictionary<string,int> convertDict = GetLookupDict();

                // Loop through the dict - subtracing amount each time - break when subtotal is 0   
                foreach(var item in convertDict) {
                    if (subTotal == 0) {
                        break;
                    }
                while (subTotal >= item.Value) {
                    
                    // Append the roman numeral to the result string    
                    result += item.Key;

                    // subtract
                    subTotal -= item.Value;
                }
            }
            string outputMsg = valueToConvert.ToString() + " is " + result + " as a Roman Numeral";
            Console.WriteLine(outputMsg);
        }
    
        else {
        Console.WriteLine("Error: Value Passed isn't Considered an appropriate integer");
        }
    }

    private static Dictionary<string,int> GetLookupDict() {
        
        // Key Value Pairs of Roman Symbol - Numeric equvalent
        // Note: I am adding these in a descending order - this is important
        Dictionary<string,int> convertDict = new Dictionary<string, int>();
        convertDict.Add("M",1000);
        convertDict.Add("CM",900);
        convertDict.Add("D",500);
        convertDict.Add("CD",400);
        convertDict.Add("C",100);
        convertDict.Add("XC",90);
        convertDict.Add("L",50);
        convertDict.Add("XL",40);
        convertDict.Add("X",10);
        convertDict.Add("IX",9);
        convertDict.Add("V",5);
        convertDict.Add("IV",4);
        convertDict.Add("I",1);

        return convertDict;
    }
}
