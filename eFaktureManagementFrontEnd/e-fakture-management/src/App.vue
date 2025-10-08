<script>
import { computed, defineAsyncComponent } from 'vue'
import { useRoute } from 'vue-router'

// Dynamically require all layouts from the layouts folder (Webpack feature)
const layoutContext = require.context('@/layouts', false, /\.vue$/)

export default {
  setup() {
    const route = useRoute()

    const currentLayout = computed(() => {
      const layoutName = (route.meta && route.meta.layout) || 'MainLayout'
      const layoutPath = `./${layoutName}.vue`

      let loader

      if (layoutContext.keys().includes(layoutPath)) {
        loader = () => Promise.resolve(layoutContext(layoutPath))
      } else {
        loader = () => Promise.resolve(layoutContext('./MainLayout.vue'))
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
