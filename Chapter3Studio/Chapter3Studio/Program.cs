//TODO: Write a program to count the number of times each character occurs in a string and then print the results to the console.

Dictionary<char, int> charArray = [];
string phrase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

foreach (char character in phrase.ToCharArray())
{
    if(!charArray.ContainsKey(character))   //If the character is NOT in the dictionary 
    {
        charArray.Add(character, 1);        //add charcter and talley to dictionary
    } 
    else                                   //If the character IS in the dictionary
    {
        charArray[character] ++;           //add talley to already established character
    }
}

foreach (KeyValuePair<char, int> kvp in charArray)  //prints key and value
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}

Console.WriteLine("Enter a phrase in here: ");
string? input = Console.ReadLine();

