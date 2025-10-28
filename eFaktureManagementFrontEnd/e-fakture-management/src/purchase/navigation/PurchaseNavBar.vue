<script setup>

import NavBar from '@/components/navigation/NavBar.vue';
import { defineProps, defineEmits, computed, ref } from 'vue';

const props = defineProps({
    modelValue: String
});

const emit = defineEmits(['update:modelValue']);

const localValue = computed({
    get: () => props.modelValue,
    set: (val) => emit('update:modelValue', val)
});

const navigationGroups = ref([
    {
        title: "Lanac snabdevanja",
        icon: "mdi-truck",
        items: [
            { title: "Dodela", icon: "mdi-file-plus", to: "/purchase/unassigned" },
            { title: "Dodeljene fakture", icon: "mdi-file-check" },
            { title: "Fakture koje nisu za knjizenje", icon: "mdi-file-remove" }
        ]
    },
    {
        title: "Odobravanje",
        icon: "mdi-check-decagram",
        items: [
            { title: "Moje fakture", icon: "mdi-account-circle" }
        ]
    },
    {
        title: "Knjizenje",
        icon: "mdi-book-open-variant",
        items: [
            { title: "Moje fakture na knjizenju", icon: "mdi-file-document-edit" },
            { title: "Proknjizene fakture", icon: "mdi-file-document-check" }
        ]
    }
]);

</script>
<template>
   <NavBar v-model="localValue" :navigationGroups="navigationGroups"></NavBar>
</template>
