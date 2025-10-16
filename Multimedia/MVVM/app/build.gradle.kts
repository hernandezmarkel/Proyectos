plugins {
    alias(libs.plugins.android.application)
}

android {
    namespace = "eus.markelhernandez.mvvm"
    compileSdk = 36

    buildFeatures {
        viewBinding = true
    }

    defaultConfig {
        applicationId = "eus.markelhernandez.mvvm"
        minSdk = 29
        targetSdk = 36
        versionCode = 1
        versionName = "1.0"

        testInstrumentationRunner = "androidx.test.runner.AndroidJUnitRunner"
    }

    buildTypes {
        release {
            isMinifyEnabled = false
            proguardFiles(
                getDefaultProguardFile("proguard-android-optimize.txt"),
                "proguard-rules.pro"
            )
        }
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_11
        targetCompatibility = JavaVersion.VERSION_11
    }
}

dependencies {
    //viewmodel and livedata
    implementation ("androidx.lifecycle:lifecycle-viewmodel:2.9.4")
    implementation ("androidx.lifecycle:lifecycle-livedata:2.9.4")
    //navigation
    implementation ("androidx.navigation:navigation-fragment:2.9.5")
    implementation ("androidx.navigation:navigation-ui:2.9.5")
    implementation(libs.appcompat)
    implementation(libs.material)
    implementation(libs.activity)
    implementation(libs.constraintlayout)
    testImplementation(libs.junit)
    androidTestImplementation(libs.ext.junit)
    androidTestImplementation(libs.espresso.core)
}