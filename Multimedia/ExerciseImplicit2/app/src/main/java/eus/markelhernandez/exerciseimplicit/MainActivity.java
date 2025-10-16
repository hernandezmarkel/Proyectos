package eus.markelhernandez.exerciseimplicit;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText etMap, etWeb;
    Button btnMap, btnWeb, btnCamera;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etMap = findViewById(R.id.etMap);
        etWeb = findViewById(R.id.etWeb);
        btnMap = findViewById(R.id.btnMap);
        btnWeb = findViewById(R.id.btnWeb);
        btnCamera = findViewById(R.id.btnCamera);
        EditText etShare = findViewById(R.id.etShare);
        Button btnShare = findViewById(R.id.btnShare);

        // 1. Abrir Google Maps
        btnMap.setOnClickListener(v -> {
            String location = etMap.getText().toString();
            if (!location.isEmpty()) {
                Uri gmmIntentUri = Uri.parse("geo:0,0?q=" + Uri.encode(location));
                Intent mapIntent = new Intent(Intent.ACTION_VIEW, gmmIntentUri);
                mapIntent.setPackage("com.google.android.apps.maps");
                if (mapIntent.resolveActivity(getPackageManager()) != null) {
                    startActivity(mapIntent);
                } else {

                    String url = "https://www.google.com/maps/search/?api=1&query=" + Uri.encode(location);
                    Intent webIntent = new Intent(Intent.ACTION_VIEW, Uri.parse(url));
                    startActivity(webIntent);
                }
            }
        });


        btnWeb.setOnClickListener(v -> {
            String url = etWeb.getText().toString();
            if (!url.startsWith("http://") && !url.startsWith("https://")) {
                url = "https://" + url;
            }
            Intent webIntent = new Intent(Intent.ACTION_VIEW, Uri.parse(url));
            startActivity(webIntent);
        });

        // 3. Abrir cámara
        btnCamera.setOnClickListener(v -> {
            Intent cameraIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
            if (cameraIntent.resolveActivity(getPackageManager()) != null) {
                startActivity(cameraIntent);
            } else {
                Toast.makeText(this, "ez da aplikazioa aurkitu", Toast.LENGTH_SHORT).show();
            }
        });
        btnShare.setOnClickListener(v -> {
            String textToShare = etShare.getText().toString();
            if (!textToShare.isEmpty()) {
                Intent shareIntent = new Intent();
                shareIntent.setAction(Intent.ACTION_SEND);
                shareIntent.putExtra(Intent.EXTRA_TEXT, textToShare);
                shareIntent.setType("text/plain");

                Intent chooser = Intent.createChooser(shareIntent, "Partekatu");
                startActivity(chooser);
            } else {
                Toast.makeText(this, "idatzi zerbait", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
