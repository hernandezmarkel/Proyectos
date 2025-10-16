package eus.markelhernandez.mvvm;

import android.app.Application;

import androidx.annotation.NonNull;
import androidx.lifecycle.AndroidViewModel;
import androidx.lifecycle.MutableLiveData;

import java.util.concurrent.Executor;
import java.util.concurrent.Executors;

public class MyMortageViewModel extends AndroidViewModel {

    Executor executor;

    MortageSimulator simulator;

    MutableLiveData<Double> payment = new MutableLiveData<>();
    MutableLiveData<Double> errorCapital = new MutableLiveData<>();
    MutableLiveData<Integer> errorDeadline = new MutableLiveData<>();
    MutableLiveData<Boolean> calculating= new MutableLiveData<>();

    public MyMortageViewModel (@NonNull Application application) {
        super(application);

        executor = Executors.newSingleThreadExecutor();
        simulator = new MortageSimulator();
    }

    public void calculate(double capital, int deadline) {

        final MortageSimulator.Request request = new MortageSimulator.Request(capital, deadline);

        executor.execute(new Runnable() {
            @Override
            public void run() {

                simulator.calculate(request, new MortageSimulator.Callback() {
                    @Override
                    public void whenPaymentIsCalculated(double resultingPayment) {
                        errorCapital.postValue(null);
                        errorDeadline.postValue(null);
                        payment.postValue(resultingPayment);
                    }
                    @Override
                    public void whenErrorCapitalBelowMin(double minimunCapital) {
                        errorCapital.postValue(minimunCapital);
                    }
                    @Override
                    public void whenErrorDeadlineBelowMin(int minimunDeadline) {
                        errorDeadline.postValue(minimunDeadline);
                    }

                    @Override
                    public void onCalculatingStart() {
                        calculating.postValue(true);
                    }

                    @Override
                    public void onCalculatingEnd() {
                        calculating.postValue(false);
                    }
                });
            }
        });
    }
}