<script>
import PagingTable from '@/components/paging/PagingTable.vue';

export default {
  name: 'HelloWorld',
    components: {
    PagingTable
  },

  data:function(){
    return{
      data:[
  { id: 101, vendor: 'Delta Trade', status: 'Pending' },
  { id: 102, vendor: 'Nova Faktura', status: 'Approved' },
  { id: 103, vendor: 'Balkan Supply', status: 'Rejected' },
  { id: 104, vendor: 'EuroKomerc', status: 'Pending' },
  { id: 105, vendor: 'TechnoServis', status: 'Approved' }
]
    }

  },
  props: {
    msg: String
  }
}
</script>

<template>
  <div class="pa-5">

    <v-card class="mx-auto" prepend-icon="" subtitle="Pregled kreiranih izlaznih faktura">
      <template v-slot:title>
        <span class="font-weight-black">My created</span>
      </template>

      <v-card-text class="bg-surface-light pt-4">
        <PagingTable page="1" totalPages="20" filtered="100" total="1244" v-model="data"></PagingTable>
        
      </v-card-text>
    </v-card>
  </div>

</template>
