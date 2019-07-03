using System; 
class NumtoWordConvert  
{ 
 
static string []one = {"", "one ", "two ", "three ", "four ", 
                       "five ", "six ", "seven ", "eight ", 
                       "nine ", "ten ", "eleven ", "twelve ", 
                       "thirteen ", "fourteen ", "fifteen ", 
                       "sixteen ", "seventeen ", "eighteen ", 
                       "nineteen "}; 
 
static string []ten = {"", "", "twenty ", "thirty ", "forty ", 
                       "fifty ", "sixty ", "seventy ", "eighty ", 
                       "ninety "}; 
  
static string numToWords(int n, string s)  
{ 
    string str = ""; 

    if (n > 19)  
    { 
        str += ten[n / 10] + one[n % 10]; 
    } 
    else
    { 
        str += one[n]; 
    } 
 
    if (n != 0)  
    { 
        str += s; 
    } 
  
    return str; 
} 
  
static string convertToWords(long n) 
{ 
      
 
    string out1 = ""; 
  
 
    out1 += numToWords((int) (n / 10000000),  
                                  "crore "); 
  
    out1 += numToWords((int) ((n / 100000) % 100),  
                                         "lakh "); 
 
    out1 += numToWords((int) ((n / 1000) % 100),  
                                   "thousand "); 

    out1 += numToWords((int) ((n / 100) % 10),  
                                  "hundred "); 
  
    if (n > 100 && n % 100 > 0)  
    { 
        out1 += "and "; 
    } 
  
  
    out1 += numToWords((int) (n % 100), ""); 
  
    return out1; 
} 
  
 
static void Main()  
{ 
  
    long n = 999999999; 
 
    Console.WriteLine(convertToWords(n)); 
} 
} 
  