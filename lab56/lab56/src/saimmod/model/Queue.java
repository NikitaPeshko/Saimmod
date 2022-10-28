package saimmod.model;

public class Queue {
    private Request request = null;

    public boolean isEmpty() {
        return request == null;
    }

    public boolean hasRequest() {
        return request != null;
    }

    public Request getRequest() {
        return request;
    }

    public void setRequest(Request request) {
        this.request = request;
    }

    public void clear() {
        request = null;
    }
}
