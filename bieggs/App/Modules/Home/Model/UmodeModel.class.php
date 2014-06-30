<?php
class UmodeModel extends Model {
    // $user_id = 1873372;
    public function getNameList(){
        return $this->where('user_id='.'1873372')->field('name')->select();
    }

    public function getSpecMode($id){
        return $this->where('user_id='.'1873372')->field('U_ALLSMONEY')->limit($id,1)->select();
    }
}