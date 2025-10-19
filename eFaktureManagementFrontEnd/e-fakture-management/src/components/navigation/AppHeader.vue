<script>
import InvoiceType from '@/util/InvoiceType';
import { mapState, mapMutations } from 'vuex';


export default {
  props: {
    modelValue: Boolean
  },
   computed: {
    ...mapState(['area']),
    areaSelected: {
      get() {
        return this.area;
      },
      set(value) {
        this.updateArea(value);
      }
    }
  },
  methods: {
    toggle() {
      this.$emit('update:modelValue', !this.modelValue)
    },
        ...mapMutations(['updateArea']),

    areaChanged(val) {
      if (val == InvoiceType.PURCHASE) {
        this.$router.push('/purchase/unassigned');
      } else {
        this.$router.push('/sales/my-created');
      }
    }
  },
  data() {
    return {
      sales: false,
      InvoiceType
    };
  },
  mounted() {
    console.log(this.mode);
  },


};
</script>

<template>
  <v-app-bar app fixed :elevation="2" color="lime-lighten-2" scroll-behavior="collapse" scroll-threshold="100">
    <template v-slot:prepend>
      <v-app-bar-nav-icon :icon="modelValue ? 'mdi-menu-open' : 'mdi-menu'" :active="modelValue"
        @click="toggle()"></v-app-bar-nav-icon>
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
      <v-btn-toggle v-model="areaSelected" variant="outlined" divided @update:modelValue="this.areaChanged">
        <v-btn :value="InvoiceType.SALES">
          <div class="d-flex align-center flex-column justify-center">

            Sales
            <v-sheet color="orange-darken-2" height="4" width="100%" tile></v-sheet>
          </div>
        </v-btn>
        <v-btn :value="InvoiceType.PURCHASE">
          <div class="d-flex align-center flex-column justify-center">

            Purchase
            <v-sheet color="teal-darken-3" height="4" width="100%" tile></v-sheet>
          </div>
        </v-btn>

      </v-btn-toggle>


      <router-link to="/login">
        <v-btn><v-icon icon="mdi-login"></v-icon>Log in
        </v-btn>
      </router-link>

    </template>

  </v-app-bar>
</template>
