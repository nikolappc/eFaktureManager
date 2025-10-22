<template>
  <div class="flex flex-col h-full">
    <v-text-field label="Prepend inner" prepend-inner-icon="mdi-map-marker" variant="solo"></v-text-field>

  </div>
</template>

<script>
import { shallowRef, computed, watch } from 'vue'

export default {
  name: "TextFilter",
  props: {
    modelValue: String
  },
  emits: ['filtered'],

  methods:{

  },
  setup(props, { emit }) {
    const text = computed({
      get: () => props.page,
      set: (val) => emit('updatePage', val)
    })



    return {
      pageValue,
      pageSizeSelect,
      pageSizeOptions
    }
  }
}
</script>