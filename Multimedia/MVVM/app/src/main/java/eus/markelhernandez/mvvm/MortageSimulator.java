package eus.markelhernandez.mvvm;

public class MortageSimulator {

    public static class Request{
        public double capital;
        public int deadline;

        public Request(double capital, int deadline) {
            this.capital = capital;
            this.deadline = deadline;
        }
    }

    interface Callback {
        void whenPaymentIsCalculated(double payment);
        void whenErrorCapitalBelowMin(double minimunCapital);
        void whenErrorDeadlineBelowMin(int minimunDeadline);
        void onCalculatingStart();
        void onCalculatingEnd();
    }



    public void calculate(Request request, Callback callback) {
        double interest = 0;
        double minimunCapital = 0;
        int minimunDeadline= 0;

        callback.onCalculatingStart();

        // ...



        try {
            Thread.sleep(2500);  // long run operation
            interest = 0.01605;
            minimunCapital = 1000;
            minimunDeadline = 2;
        } catch (InterruptedException e) {}

        boolean error = false;
        if (request.capital < minimunCapital) {
            callback.whenErrorCapitalBelowMin(minimunCapital);
            error = true;
        }

        if (request.deadline < minimunDeadline) {
            callback.whenErrorDeadlineBelowMin(minimunDeadline);
            error = true;
        }
        if(!error) {
            callback.whenPaymentIsCalculated((request.capital * interest / 12 / (1 - Math.pow(1 + (interest / 12), -request.deadline* 12))) + request.capital / request.deadline+);

        }

        callback.onCalculatingEnd();
    }
}