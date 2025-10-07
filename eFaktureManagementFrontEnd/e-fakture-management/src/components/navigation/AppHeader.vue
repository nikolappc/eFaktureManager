<template>
      <v-app-bar :elevation="2" color="lime-lighten-2">
        <template v-slot:prepend>
          <v-app-bar-nav-icon></v-app-bar-nav-icon>
        </template>
      
        <v-app-bar-title >eFakture management</v-app-bar-title>
   
         <router-link to="/"><v-btn ><v-icon icon="mdi-home"></v-icon>Home </v-btn></router-link>
         <router-link to="/about"><v-btn ><v-icon icon="mdi-information-slab-circle-outline"></v-icon>About </v-btn></router-link>
         <v-spacer></v-spacer>


      </v-app-bar>
</template>

<script>
// @ is an alias to /src

export default {
    name: 'AppHeader',
  
}
</script>
