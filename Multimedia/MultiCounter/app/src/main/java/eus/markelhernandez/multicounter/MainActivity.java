package eus.markelhernandez.multicounter;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import eus.markelhernandez.multicounter.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {
    private int kontadore1 = 0;
    private int kontadore2 = 0;
    private int kontadore3 = 0;
    private int kontadore4 = 0;
    private int kontadoreglobala = 0;

    ActivityMainBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        // setContentView(R.layout.activity_main);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        binding.btnCounter1.setOnClickListener(v -> {
            kontadore1++;
            kontadoreglobala++;
            binding.txtCounter1.setText(String.valueOf(kontadore1));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset1.setOnClickListener(v -> {
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala - kontadore1));
            binding.txtCounter1.setText(String.valueOf(kontadore1 = 0));
        });

        binding.btnCounter2.setOnClickListener(v -> {
            kontadore2++;
            kontadoreglobala++;
            binding.txtCounter2.setText(String.valueOf(kontadore2));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset2.setOnClickListener(v -> {
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala - kontadore2));
            binding.txtCounter2.setText(String.valueOf(kontadore2 = 0));
        });

        binding.btnCounter3.setOnClickListener(v -> {
            kontadore3++;
            kontadoreglobala++;
            binding.txtCounter3.setText(String.valueOf(kontadore3));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset3.setOnClickListener(v -> {
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala - kontadore3));
            binding.txtCounter3.setText(String.valueOf(kontadore3 = 0));
        });

        binding.btnCounter4.setOnClickListener(v -> {
            kontadore4++;
            kontadoreglobala++;
            binding.txtCounter4.setText(String.valueOf(kontadore4));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset4.setOnClickListener(v -> {
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala - kontadore4));
            binding.txtCounter4.setText(String.valueOf(kontadore4 = 0));

        });

        binding.btnResetAll.setOnClickListener(v -> {
            binding.txtCounter1.setText(String.valueOf(kontadore1 = 0));
            binding.txtCounter2.setText(String.valueOf(kontadore2 = 0));
            binding.txtCounter3.setText(String.valueOf(kontadore3 = 0));
            binding.txtCounter4.setText(String.valueOf(kontadore4 = 0));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala = 0));
        });
    }
}