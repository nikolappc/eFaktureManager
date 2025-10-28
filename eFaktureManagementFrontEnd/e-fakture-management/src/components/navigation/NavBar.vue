<script setup>

import { defineProps, defineEmits, computed, ref } from 'vue';
import ListItem from './ListItem.vue';

const props = defineProps({
    modelValue: String,
    navigationGroups: Array
});
const emit = defineEmits(['update:modelValue']);

const localValue = computed({
    get: () => props.modelValue,
    set: (val) => emit('update:modelValue', val)
});


</script>
<template>
    <v-navigation-drawer v-model="localValue" :order="1" app class="bg-grey-lighten-4">
        <v-list>

            <template v-for="(group, index) in navigationGroups" :key="index">
                <ListItem :group="group"></ListItem>
            </template>

        </v-list>

    </v-navigation-drawer>
</template>
