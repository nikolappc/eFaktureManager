<script>
import { computed, defineAsyncComponent } from 'vue'
import { useRoute } from 'vue-router'

// Dynamically require all layouts from the layouts folder (Webpack feature)

export default {



  setup() {
    var layoutMaps = {
      "SalesLayout": "@/sales/layouts/SalesLayout.vue",
      "PurchaseLayout": "@/purchase/layouts/PurchaseLayout.vue",
      "LoginLayout": "@/layouts/LoginLayout.vue",
      "MainLayout": "@/layouts/LoginLayout.vue"
    }
    const route = useRoute()

    const currentLayout = computed(() => {
      const layoutName = (route.meta && route.meta.layout) || 'MainLayout'

      let loader;

      if (layoutMaps.keys().includes(layoutName)) {
        loader = () => import(layoutMaps[layoutName])
      } else {
        loader = () => import(layoutMaps["LoginLayout"])
      }

      return defineAsyncComponent(loader)
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
