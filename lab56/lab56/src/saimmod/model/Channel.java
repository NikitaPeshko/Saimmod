package saimmod.model;

public class Channel {
    private Request request = null;

    public boolean isFree() {
        return request == null;
    }

    public boolean isBusy() {
        return request != null;
    }

    public Request getRequest() {
        return request;
    }

    public void setRequest(Request request) {
        this.request = request;
    }

    public void stop() {
        request = null;
    }
}
