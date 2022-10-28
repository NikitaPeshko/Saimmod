package saimmod;

import java.util.InputMismatchException;
import java.util.Scanner;

public class InputData {
    public static double inputDouble(String strValue) {
        while (true) {
            Scanner scan = new Scanner(System.in);
            System.out.print("Input " + strValue + ": ");
            try {
                return scan.nextDouble();
            } catch (InputMismatchException e) {
                System.out.println("Sorry! Value " + strValue + " must be Double (e.g. 1,8 or 2)");
            }
        }
    }

    public static int inputInt(String strValue) {
        while (true) {
            Scanner scan = new Scanner(System.in);
            System.out.print("Input " + strValue + ": ");
            try {
                return scan.nextInt();
            } catch (NumberFormatException e) {
                System.out.println("Sorry! Value " + strValue + " must be Integer (e.g. 100000)");
            }
        }
    }
}
