
<script>
import { useRouter } from 'vue-router';

    const router = useRouter();

export default {
  props: {
    modelValue: Boolean
  },
  methods: {
    toggle() {
      this.$emit('update:modelValue', !this.modelValue)
    }
  },
  data() {
    return {
      sales:false
    };
  },
  mounted() {
    console.log(this.mode);
  },
  salesChanged(val){
      if(val){
        router.push('/purchase/unassigned');
      }else{
        router.push('/sales/my-created'); 
      }
  }

};
</script>

<template>
  <v-app-bar app fixed :elevation="2" color="lime-lighten-2" scroll-behavior="collapse" scroll-threshold="100">
    <template v-slot:prepend>
      <v-app-bar-nav-icon :icon="modelValue?'mdi-menu-open':'mdi-menu'"  :active="modelValue"  @click="toggle()"></v-app-bar-nav-icon>
      <v-app-bar-title class="bg-white pa-1 ps-3 pe-3 rounded-lg">eFakture management</v-app-bar-title>
    </template>

    <template v-slot:append>

      <router-link to="/">
        <v-btn><v-icon icon="mdi-home"></v-icon>Home </v-btn>
      </router-link>
      <router-link to="/about">
        <v-btn><v-icon icon="mdi-information-slab-circle-outline"></v-icon>About
        </v-btn>
      </router-link>
      <span>
        Purchase
      </span>
      <v-switch v-model="this.sales" @update:valueModel="this.salesChanged" label="Sale"></v-switch>


      <router-link to="/login">
        <v-btn><v-icon icon="mdi-login"></v-icon>Log in
        </v-btn>
      </router-link>

    </template>

  </v-app-bar>
</template>


