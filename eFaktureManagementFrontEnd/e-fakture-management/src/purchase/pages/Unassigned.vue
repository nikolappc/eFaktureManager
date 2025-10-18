
<script>
import PagingTable from '@/components/paging/PagingTable.vue';
export default {
  name: 'Unassigned-Table',
  props: {
    msg: String
  }
}
</script>
<template>
  <PagingTable page="1" totalPages="20" filtered="100" total="1244" :v-model="[]"  ></PagingTable>
</template>

