 
import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;
import java.util.stream.Stream;

public class Solution{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int size = 4;

        Book[] books = new Book[size];
        for(int i=0; i<size; i++){
            int id = sc.nextInt();sc.nextLine();
            int p = sc.nextInt();sc.nextLine();
            String t = sc.nextLine();
            String a = sc.nextLine();
            double price = sc.nextDouble();sc.nextLine();

            books[i] = new Book(id, p, t, a, price);

        }

        String title = sc.nextLine();

        Book[] ans1 = findBookWithMaximumPrice(books);

        if(ans1 != null){
            for(Book b : ans1){
                System.out.println(b.getId() +": "+ b.getTitle());
            }
        }else{
            System.out.println("No Book found with mentioned attribute.");
        }

        Book ans2 = searchBookByTitle(books, title);

        if(ans2 != null){
            System.out.println(ans2.getId() +": "+ ans2.getPages());
        }else{
            System.out.println("No Book found with mentioned attribute.");
        }

    }

    public static Book[] findBookWithMaximumPrice(Book[] books){        
        double maxPrice = Integer.MIN_VALUE;
        Book[] ansBooks = new Book[0];
        for(Book b : books){
            if(b.getPrice() >= maxPrice){
                maxPrice = b.getPrice();
            }
        }

        for(Book b: books){
            if(b.getPrice() == maxPrice){
                ansBooks = Arrays.copyOf(ansBooks, ansBooks.length+1);
                ansBooks[ansBooks.length-1] = b;
            }
        }

        return ansBooks;

        // return Arrays.stream(books)
        //                 .max((b1,b2) -> Double.compare(b1.getPrice(), b2.getPrice()))
        //                 .orElse(null);

    }

    public static Book searchBookByTitle(Book[] books, String title){

        return Arrays.stream(books)
                        .filter(b -> b.getTitle().equalsIgnoreCase(title))
                        .findFirst()
                        .orElse(null);
                        
    }

}

 