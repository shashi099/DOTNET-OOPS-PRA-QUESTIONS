import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Solution{
    public static void main(String[] args) { 
        Medicine[] medicines = new Medicine[4];
        Scanner sc = new Scanner(System.in);

        for(int i=0; i<4; i++){
            String mname = sc.nextLine();
            String b = sc.nextLine();
            String die = sc.nextLine();
            int p = sc.nextInt();sc.nextLine();

            medicines[i] = new Medicine(mname, b, die, p);

        }

        String d = sc.nextLine();

        int[] ans = getPriceByDisease(medicines, d);

        if(ans != null){
            for(int val : ans){
                System.out.println(val);
            }
        }

    }

    public static int[] getPriceByDisease(Medicine[] med, String disease){

        int[] prices = new int[0];

        for(Medicine m : med){
            if(m.getDisease().equalsIgnoreCase(disease)){
                prices = Arrays.copyOf(prices, prices.length+1);
                prices[prices.length -1] = m.getPrice();
            }
        }

        Arrays.sort(prices);

        if(prices.length == 0){
            return null;
        }
        return prices;
    }
}