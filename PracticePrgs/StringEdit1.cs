using System;

namespace PracticePrgs{
public class StringEdit1{
    public bool CheckStrings(string str1, string str2)
    {
        //return true if both are identical strings
        if (str1 == str2)
        {
            return true;
        }

        switch (str1.Length - str2.Length)
        {
            case 0:
            case 1:
                return CompareStrings(str1, str2);
            case -1:
                return CompareStrings(str2, str1);
            default:
                return false;
        }
    }

    public bool CompareStrings(string str1, string str2)
    {
        bool edited = false;
        int i = 0;
        int j = 0;
        do {
            if (str1[i] == str2[j]) {
                i++;
                j++;
            } else {
                if (!edited) {
                    edited = true;
                    i++;
                    if (str1.Length == str2.Length){
                        j++;
                    }
                } else {
                    return false;
                }
            }
        } while (j < str2.Length);
        return true;
    }

    public bool IsRotation(string s1, string s2)
    {
        if (s1 == string.Empty || s2 == string.Empty)
        {
            return false;
        }
        if (s1.Length != s2.Length) {
            return false;
        }
        s1 += s1;
        return s1.Contains(s2);
    }
}
}