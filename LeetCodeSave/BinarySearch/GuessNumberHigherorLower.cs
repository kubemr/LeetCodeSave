namespace LeetCodeSave.BinarySearch;

public class GuessNumberHigherorLower //53, can't be bothered to make a class, so done fully in leetcode
{
    /*
 Forward declaration of guess API.
 @param  num   your guess
 @return 	     -1 if num is higher than the picked number
 			      1 if num is lower than the picked number
                otherwise return 0
  int guess(int num);
 */

    
    /*public int GuessNumber(int n) {
        int left = 1,right = n;

        while(left <= right){
            int mid = left + (right - left)/2;
            int num = guess(mid);
            if(num == 0)
                return mid;
            else if(num == -1)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }*/
}