<script setup>

import NavBar from '@/components/navigation/NavBar.vue';
import { defineProps, defineEmits, computed, ref} from 'vue';


const props = defineProps({
    modelValue: String
});
const emit = defineEmits(['update:modelValue']);

const localValue = computed({
    get: () => props.modelValue,
    set: (val) => emit('update:modelValue', val)
});

const navigationItems = ref([
  {
    title: "Nove fakture",
    icon: "mdi-file-document-outline",
    items: [
      { title: "Kreiraj fakturu", icon: "mdi-file-plus-outline", to: '/sales/create'},
      { title: "Skice", icon: "mdi-file-edit-outline" }
    ]
  },
  {
    title: "Upravljanje",
    icon: "mdi-cog-outline",
    items: [
      { title: "Moje fakture", icon: "mdi-file-account-outline", to:"/sales/my-created"}
    ]
  },
  {
    title: "Greške",
    icon: "mdi-alert-circle-outline",
  }
]);

</script>
<template>
   <NavBar v-model="localValue" :navigationGroups="navigationItems"></NavBar>

</template>
