<?php
class UserBetsModel extends Model {
    
    public function getData($LID){
        return $this->where('LID='.$LID)->field(true)->limit(1)->select();
    }

}