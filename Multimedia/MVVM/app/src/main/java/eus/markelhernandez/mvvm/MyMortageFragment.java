package eus.markelhernandez.mvvm;

import android.os.Bundle;

import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

/**
 * A simple {@link Fragment} subclass.
 * Use the {@link MyMortageFragment#newInstance} factory method to
 * create an instance of this fragment.
 */
import androidx.annotation.NonNull;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProvider;

import eus.markelhernandez.mvvm.databinding.FragmentMyMortageBinding;

public class MyMortageFragment extends Fragment {
    private FragmentMyMortageBinding binding;

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        binding = FragmentMyMortageBinding.inflate(inflater, container, false);
        return binding.getRoot();
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        final MyMortageViewModel myMortgageViewModel = new ViewModelProvider(this).get(MyMortageViewModel.class);

        binding.calculate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                boolean error = false;
                double capital = Double.parseDouble(binding.capital.getText().toString());
                int deadline = Integer.parseInt(binding.deadline.getText().toString());

                myMortgageViewModel.calculate(capital, deadline);

                try {
                    capital = Double.parseDouble(binding.capital.getText().toString());
                } catch (Exception e){
                    binding.capital.setError("Introduce a number");
                    error = true;
                }

                try {
                    deadline = Integer.parseInt(binding.deadline.getText().toString());
                } catch (Exception e){
                    binding.deadline.setError("Introduce a number");
                    error = true;
                }

                if (!error) {
                    myMortgageViewModel.calculate(capital, deadline);
                }
            }
        });

        myMortgageViewModel.payment.observe(getViewLifecycleOwner(), new Observer<Double>() {
            @Override
            public void onChanged(Double payment) {
                binding.payment.setText(String.format("%.2f",payment));
            }
        });

        myMortgageViewModel.errorCapital.observe(getViewLifecycleOwner(), new Observer<Double>() {
            @Override
            public void onChanged(Double minimunCapital) {
                if (minimunCapital!= null) {
                    binding.capital.setError("The capital can not be less than " + minimunCapital+ " euros");
                } else {
                    binding.capital.setError(null);
                }
            }
        });

        myMortgageViewModel.errorDeadline.observe(getViewLifecycleOwner(), new Observer<Integer>() {
            @Override
            public void onChanged(Integer minimunDeadline) {
                if (minimunDeadline!= null) {
                    binding.deadline.setError("The deadline can not be less than " + minimunDeadline+ " months");
                } else {
                    binding.deadline.setError(null);
                }
            }
        });

        myMortgageViewModel.calculating.observe(getViewLifecycleOwner(), new Observer<Boolean>() {
            @Override
            public void onChanged(Boolean calculating) {
                if (calculating) {
                    binding.calculating.setVisibility(View.VISIBLE);
                    binding.payment.setVisibility(View.GONE);
                } else {
                    binding.calculating.setVisibility(View.GONE);
                    binding.payment.setVisibility(View.VISIBLE);
                }
            }
        });
    }
}