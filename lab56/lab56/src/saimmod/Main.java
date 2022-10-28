package saimmod;

import saimmod.model.QueueingSystem;

import static saimmod.InputData.inputDouble;
import static saimmod.InputData.inputInt;

public class Main {
    public static void main(String[] args) {

//        double m = inputDouble("m");
//        double l = inputDouble("l");
//        double p = inputDouble("p");
        //int simulationTime = inputInt("simulation time");
        int simulationTime=100000;
        //QueueingSystem queueingSystem = new QueueingSystem(m, l, p, simulationTime);

         QueueingSystem queueingSystem = new QueueingSystem(0.5, 0.45, 0.4, 100000);
        int[] requests = queueingSystem.run();
        double denied1 = queueingSystem.getDeniedRequests1();
        double denied2 = queueingSystem.getDeniedRequests2();
        double success1 = queueingSystem.getSuccessRequest1(requests);
        double success2 = queueingSystem.getSuccessRequest2(requests);

        System.out.println("P отказа 1 = " + denied1 / requests[0]);
        System.out.println("P отказа 2 = " + denied2 / requests[1]);
        System.out.println("\nОтносительные пропускные спопобности:");

        System.out.println("Q 1 = " + (success1 / requests[0]));
        System.out.println("Q 2 = " + (success2 / requests[1]));
    }
}