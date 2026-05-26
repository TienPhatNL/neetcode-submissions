public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> di = new Dictionary<string, List<string>>();

        List<List<string>> result = new List<List<string>>();

        foreach(string s in strs){
            char[] chars = s.ToCharArray();

            Array.Sort(chars);

            string key = new string(chars);

            if(di.ContainsKey(key)) di[key].Add(s);
            else di.Add(key, new List<string>{s});
        }

        foreach(var i in di){
            result.Add(i.Value);
        }

        return result;
    }
}