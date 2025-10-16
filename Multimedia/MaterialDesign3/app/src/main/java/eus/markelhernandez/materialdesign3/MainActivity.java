package eus.markelhernandez.materialdesign3;

import android.os.Bundle;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.button.MaterialButton;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;
public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;


        });

        MaterialButton btnStart = findViewById(R.id.btnStart);
        btnStart.setOnClickListener(v ->
                Toast.makeText(this, "Hello Material 3!", Toast.LENGTH_SHORT).show()
        );

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(v ->
                Snackbar.make(v, "FAB clicked!", Snackbar.LENGTH_SHORT).show()
        );

        BottomNavigationView bottomNav = findViewById(R.id.bottomNav);
        bottomNav.setOnItemSelectedListener(item -> {
            int id = item.getItemId();
            if(id == R.id.nav_home){
                Toast.makeText(this, "Home selected", Toast.LENGTH_SHORT).show();
            } else if(id == R.id.nav_profile){
                Toast.makeText(this, "Profile selected", Toast.LENGTH_SHORT).show();
            }
            return true;
        });
    }
}