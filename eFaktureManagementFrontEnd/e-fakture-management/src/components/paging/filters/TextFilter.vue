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

    return{


    }
  },
  setup(props, { emit }) {
    const text = computed({
      get: () => props.page,
      set: (val) => emit('updatePage', val)
    })

    const pageSizeSelect = shallowRef({ title: '25 per page', size: 25 })

    const pageSizeOptions = [
      { title: '10 per page', size: 10 },
      { title: '25 per page', size: 25 },
      { title: '50 per page', size: 50 },
      { title: '100 per page', size: 100 },
      { title: '200 per page', size: 200 }
    ]

    watch(pageSizeSelect, (val) => {
      emit('updatePageSize', val.size)
    })

    return {
      pageValue,
      pageSizeSelect,
      pageSizeOptions
    }
  }
}
</script>