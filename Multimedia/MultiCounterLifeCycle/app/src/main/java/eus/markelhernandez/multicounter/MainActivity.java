package eus.markelhernandez.multicounter;

import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.snackbar.Snackbar;

import eus.markelhernandez.multicounter.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {
    private int kontadore1 = 0;
    private int kontadore2 = 0;
    private int kontadore3 = 0;
    private int kontadore4 = 0;
    private int kontadoreglobala = 0;

    ActivityMainBinding binding;

    private boolean ireki = false;
    @Override
    protected void onStart() {
        super.onStart();

    }

    @Override
    protected void onPause() {
        super.onPause();
        if (!ireki) {
            Toast.makeText(this, "Has pausado la app", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        new AlertDialog.Builder(this)
                .setTitle("Alert Dialog Title")
                .setMessage("This is an alert dialog message")
                .setPositiveButton("OK", (dialog, which) -> {
                    // Handle positive button click
                })
                .setNegativeButton("Cancel", (dialog, which) -> {
                    // Handle negative button click
                })
                .setNeutralButton("Later", (dialog, which) -> {
                    // Handle neutral button click
                })
                .show();
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);

            Toast.makeText(this, "kaixo", Toast.LENGTH_SHORT).show();

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        Snackbar snackbar = Snackbar.make(findViewById(android.R.id.content), "This is a snackbar", Snackbar.LENGTH_LONG);
        snackbar.setAction("UNDO", new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Handle the action
            }
        });
        snackbar.show();

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        if (savedInstanceState != null) {
            ireki = true;
            kontadore1 = savedInstanceState.getInt("k1");
            kontadore2 = savedInstanceState.getInt("k2");
            kontadore3 = savedInstanceState.getInt("k3");
            kontadore4 = savedInstanceState.getInt("k4");
            kontadoreglobala = savedInstanceState.getInt("kg");

            binding.txtCounter1.setText(String.valueOf(kontadore1));
            binding.txtCounter2.setText(String.valueOf(kontadore2));
            binding.txtCounter3.setText(String.valueOf(kontadore3));
            binding.txtCounter4.setText(String.valueOf(kontadore4));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        }

        binding.btnCounter1.setOnClickListener(v -> {
            kontadore1++;
            kontadoreglobala++;
            binding.txtCounter1.setText(String.valueOf(kontadore1));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset1.setOnClickListener(v -> {
            kontadoreglobala -= kontadore1;
            kontadore1 = 0;
            binding.txtCounter1.setText(String.valueOf(kontadore1));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnCounter2.setOnClickListener(v -> {
            kontadore2++;
            kontadoreglobala++;
            binding.txtCounter2.setText(String.valueOf(kontadore2));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset2.setOnClickListener(v -> {
            kontadoreglobala -= kontadore2;
            kontadore2 = 0;
            binding.txtCounter2.setText(String.valueOf(kontadore2));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnCounter3.setOnClickListener(v -> {
            kontadore3++;
            kontadoreglobala++;
            binding.txtCounter3.setText(String.valueOf(kontadore3));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset3.setOnClickListener(v -> {
            kontadoreglobala -= kontadore3;
            kontadore3 = 0;
            binding.txtCounter3.setText(String.valueOf(kontadore3));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnCounter4.setOnClickListener(v -> {
            kontadore4++;
            kontadoreglobala++;
            binding.txtCounter4.setText(String.valueOf(kontadore4));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnReset4.setOnClickListener(v -> {
            kontadoreglobala -= kontadore4;
            kontadore4 = 0;
            binding.txtCounter4.setText(String.valueOf(kontadore4));
            binding.txtGlobalView.setText(String.valueOf(kontadoreglobala));
        });

        binding.btnResetAll.setOnClickListener(v -> {
            kontadore1 = kontadore2 = kontadore3 = kontadore4 = kontadoreglobala = 0;
            binding.txtCounter1.setText("0");
            binding.txtCounter2.setText("0");
            binding.txtCounter3.setText("0");
            binding.txtCounter4.setText("0");
            binding.txtGlobalView.setText("0");
        });
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putBoolean("ireki", ireki);
        outState.putInt("k1", kontadore1);
        outState.putInt("k2", kontadore2);
        outState.putInt("k3", kontadore3);
        outState.putInt("k4", kontadore4);
        outState.putInt("kg", kontadoreglobala);
    }
}
