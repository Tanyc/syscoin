<?php
class UserModel extends Model {
    
    public function getUserByid($ID){
        return $this->where('user_id='.$ID)->find();
    }

}