<script setup>

import { defineProps, defineEmits, computed } from 'vue';

const props = defineProps({
    modelValue: String
});
const emit = defineEmits(['update:modelValue']);

const localValue = computed({
    get: () => props.modelValue,
    set: (val) => emit('update:modelValue', val)
});

</script>
<template>
    <v-navigation-drawer v-model="localValue" :order="1" app>
        <v-list>

            <v-list-group value="Nove fakture">
                <template v-slot:activator="{ props }">
                    <v-list-item v-bind="props" title="Nove fakture"></v-list-item>
                </template>
                <v-list-item title="Kreiraj fakturu"></v-list-item>
                <v-list-item title="Skice"></v-list-item>
            </v-list-group>

            <v-list-group value="Upravljanje">
                <template v-slot:activator="{ props }">
                    <v-list-item v-bind="props" title="Upravljanje"></v-list-item>
                </template>
                <v-list-item title="Moje fakture"></v-list-item>
            </v-list-group>
            <v-list-item title="Greške"></v-list-item>
        </v-list>
    </v-navigation-drawer>
</template>
