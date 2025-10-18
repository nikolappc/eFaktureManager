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

            <v-list-group value="Lanac snabdevanja">
                <template v-slot:activator="{ props }">
                    <v-list-item v-bind="props" title="Lanac snabdevanja"></v-list-item>
                </template>
                <router-link to="/purchase/unassigned">
                    <v-list-item title="Dodela"></v-list-item>
                </router-link>
                <v-list-item title="Dodeljene fakture"></v-list-item>
                <v-list-item title="Fakture koje nisu za knjizenje"></v-list-item>
            </v-list-group>

            <v-list-group value="Odobravanje">
                <template v-slot:activator="{ props }">
                    <v-list-item v-bind="props" title="Odobravanje"></v-list-item>
                </template>
                <v-list-item title="Moje fakture"></v-list-item>
            </v-list-group>

            <v-list-group value="Knjizenje">
                <template v-slot:activator="{ props }">
                    <v-list-item v-bind="props" title="Knjizenje"></v-list-item>
                </template>
                <v-list-item title="Moje fakture na knjizenju"></v-list-item>
                <v-list-item title="Proknjizene fakture"></v-list-item>
            </v-list-group>
        </v-list>
    </v-navigation-drawer>
</template>
