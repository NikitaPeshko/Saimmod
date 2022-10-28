package saimmod.model;

public class Request {
    private final int priority;
    private final double appearedAt;
    private final double processingTime;
    private double currentProcessingTime = 0;
    private boolean completed = false;
    private boolean denied = false;

    public Request(int priority, double appearedAt, double processingTime) {
        this.priority = priority;
        this.appearedAt = appearedAt;
        this.processingTime = processingTime;
    }

    public int getPriority() {
        return priority;
    }

    public boolean isDenied() {
        return denied;
    }

    public void deny() {
        this.denied = true;
    }

    public void updateProcessingTime(double dt) {
        currentProcessingTime += dt;
        if (currentProcessingTime >= processingTime) {
            completed = true;
        }
    }

    public boolean isCompleted() {
        return completed;
    }

    public double getOverTime() {
        return currentProcessingTime - processingTime;
    }
}
