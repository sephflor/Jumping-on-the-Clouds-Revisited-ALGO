using System;

class Solution {
    static void Main(string[] args) {
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int result = jumpingOnClouds(c, k);
        Console.WriteLine(result);
    }
    
    static int jumpingOnClouds(int[] c, int k) {
        int energy = 100;
        int n = c.Length;
        int i = 0;
        
        do {
            i = (i + k) % n;
            energy--;
            if (c[i] == 1) {
                energy -= 2;
            }
        } while (i != 0);
        
        return energy;
    }
}
