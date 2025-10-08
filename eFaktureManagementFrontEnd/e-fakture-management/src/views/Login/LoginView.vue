<template>
  <v-card :elevation="20" class="pa-5 pt-2 pb-2 rounded-lg">


    <v-card-item>

      <v-card-title class="text-h4 mb-5">

          Log in
      </v-card-title>
    </v-card-item>

    <v-card-text clas="">

      <v-form @submit.prevent="onSubmit" class="d-flex flex-column gap-3 align-stretch">
        <v-text-field width="50vw" label="Email" type="email" prepend-icon="mdi-email" variant="outlined" required />

        <v-text-field width="50vw" label="Password" type="password" prepend-icon="mdi-lock" variant="outlined"
          required />

        <v-btn type="submit" color="primary" block>Login</v-btn>
      </v-form>
    </v-card-text>
  </v-card>

</template>

