// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsIsogramLinq("thumbscrewjapingly"));


static bool IsIsogram(string str)
{
   if(string.IsNullOrEmpty(str)) return false;

   var data = new Dictionary<char,int>();
   
   foreach(var c in str)
   {
        if (data.ContainsKey(char.ToLower(c)))
        {
            return false;
        }
        else
        {
            data.Add(char.ToLower(c), 1);
        }
   }

   return true;
}


static bool IsIsogramLinq(string str)
{
    if (string.IsNullOrEmpty(str)) return false;

    return str
        .GroupBy(x => char.ToLower(x))
        .Any(x => x.Count() > 1) ? false : true;
}