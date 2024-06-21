<template>
  <v-app>
    <v-layout>

      <v-app-bar :elevation="2" color="lime-lighten-2">
        <template v-slot:prepend>
          <v-app-bar-nav-icon></v-app-bar-nav-icon>
        </template>
      
        <v-app-bar-title >eFakture management</v-app-bar-title>
   
         <router-link to="/"><v-btn ><v-icon icon="mdi-home"></v-icon>Home </v-btn></router-link>
         <router-link to="/about"><v-btn ><v-icon icon="mdi-information-slab-circle-outline"></v-icon>About </v-btn></router-link>
         <v-spacer></v-spacer>


      </v-app-bar>
      <v-main>
        <v-container fluid>
          <router-view />

        </v-container>
      </v-main>
    </v-layout>
    <v-footer></v-footer>

  </v-app>
</template>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;

  a {
    font-weight: bold;
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
