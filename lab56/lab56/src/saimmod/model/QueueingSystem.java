package saimmod.model;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import static java.lang.Math.log;

public class QueueingSystem {
    private static final int FIRST_PRIORITY_REQUEST = 1;
    private static final int SECOND_PRIORITY_REQUEST = 2;
    private static final int NO_REQUEST = 0;
    private final Random randRequest;
    private final Random randTime;
    private final double p;
    private final double l;
    private final double m;
    private final int simulationTime;
    private final double averageTimeBetweenRequests;
    private final double averageProcessingTime;
    private int deniedRequests1 = 0;
    private int deniedRequests2 = 0;
    private int d = 0;

    private int successRequest1;
    private int successRequest2;

    public int getSuccessRequest1(int[] requests) {
        return requests[0]-deniedRequests1;
    }
    public int getSuccessRequest2(int[] requests) {
        return requests[1]-deniedRequests2;
    }

    public QueueingSystem(double m, double l, double p, int simulationTime) {
        this.p = p;
        this.m = m;
        this.l = l;
        this.simulationTime = simulationTime;
        this.averageTimeBetweenRequests = 1 / l;
        this.averageProcessingTime = 1 / m;
        this.randRequest = new Random(100000);
        this.randTime = new Random(100000);
    }

    public int getDeniedRequests1() {
        return deniedRequests1;
    }

    public int getDeniedRequests2() {
        return deniedRequests2;
    }

    private int getAppearedRequestPriority() {
        return randRequest.nextDouble() < p
                ? FIRST_PRIORITY_REQUEST
                : SECOND_PRIORITY_REQUEST;
    }

    private double getTimeBetweenRequests(double averageTimeBetweenRequests) {
        return -averageTimeBetweenRequests * log(randRequest.nextDouble());
    }

    private double getProcessingTime(double averageProcessingTime) {
        return -averageProcessingTime * log(randTime.nextDouble());
    }

    public int[] run() {
        double currentTime = 0;
        List<Request> requests = new ArrayList<Request>();
        Channel channel1 = new Channel();
        int request1count = 0;
        Queue queue = new Queue();
        while (currentTime < simulationTime) {
            double timePassed = getTimeBetweenRequests(averageTimeBetweenRequests);
            currentTime += timePassed;
            if (currentTime > simulationTime) {
                break;
            }
            Request request = new Request(
                    getAppearedRequestPriority(),
                    currentTime,
                    getProcessingTime(averageProcessingTime));
            requests.add(request);

            double timeLeft1 = 0;
            if (channel1.isBusy()) {
                channel1.getRequest().updateProcessingTime(timePassed);
                if (channel1.getRequest().isCompleted()) {
                    timeLeft1 = channel1.getRequest().getOverTime();
                    channel1.stop();
                }
            }

            if (queue.hasRequest()) {
                if (channel1.isFree()) {
                    channel1.setRequest(queue.getRequest());
                    channel1.getRequest().updateProcessingTime(timeLeft1);
                    if (channel1.getRequest().isCompleted()) {
                        channel1.stop();
                    }
                    queue.clear();
                }
            }
            if (request.getPriority() == FIRST_PRIORITY_REQUEST) {
                request1count++;
                if (channel1.isFree()) {
                    channel1.setRequest(request);
                } else if (channel1.getRequest().getPriority() == SECOND_PRIORITY_REQUEST) {
                    if (queue.isEmpty()) {
                        queue.setRequest(channel1.getRequest());
                    } else {
                        deniedRequests2++;
                        channel1.getRequest().deny();
                    }
                    channel1.setRequest(request);
                } else if (queue.isEmpty()) {
                    queue.setRequest(request);
                } else if (queue.getRequest().getPriority() == SECOND_PRIORITY_REQUEST) {
                    deniedRequests2++;
                    queue.getRequest().deny();
                    queue.setRequest(request);
                } else {
                    deniedRequests1++;
                    request.deny();
                }
            }
            if (request.getPriority() == SECOND_PRIORITY_REQUEST) {
                if (channel1.isFree()) {
                    channel1.setRequest(request);
                } else if (queue.isEmpty()) {
                    queue.setRequest(request);
                } else {
                    deniedRequests2++;
                    request.deny();
                }
            }
        }
        return new int[]{request1count, requests.size() - request1count};}

}
