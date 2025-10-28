<script>
import { computed, defineAsyncComponent } from 'vue'
import { useRoute } from 'vue-router'
import SalesLayout from './sales/layouts/SalesLayout.vue';
import LoginLayout from './layouts/LoginLayout.vue';
import MainLayout from './layouts/MainLayout.vue';
import PurchaseLayout from './purchase/layouts/PurchaseLayout.vue';

// Dynamically require all layouts from the layouts folder (Webpack feature)

export default {



  setup() {
    var layoutMaps = {
      "SalesLayout": SalesLayout,
      "PurchaseLayout": PurchaseLayout,
      "LoginLayout": LoginLayout,
      "MainLayout": MainLayout
    }
    const route = useRoute()

      const currentLayout = computed(() => {
      const layoutName = route.meta?.layout || 'MainLayout'
      return layoutMaps[layoutName] || LoginLayout
    })


    return { currentLayout }
  },
}
</script>

<template>
  <v-app>

    <component :is="currentLayout">
      <router-view />
    </component>
     <v-footer app class="bg-grey-lighten-2 text-caption py-1">
        eFaktureManagement © 2025
    </v-footer>

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
</style>
