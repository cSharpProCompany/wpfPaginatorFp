﻿[<AutoOpen>]
module Paginator.Types.CustomTypes
    type IntMore0Less65535Exclsv(pValue) = 
        let IsValid x =
              if x > 0us
              then x
              else failwith "Out of range"
        
        member this.Value = IsValid pValue
        static member op_Explicit source =
            IntMore0Less65535Exclsv(uint16 source)
        
        new(pValue) = IntMore0Less65535Exclsv(uint16 pValue)
        new(pValue: uint32) = IntMore0Less65535Exclsv( uint16 pValue)

    type PaginatorState = 
         {NumberOfPages  : IntMore0Less65535Exclsv
          CurrentPage    : IntMore0Less65535Exclsv
          ItemsPerPage   : IntMore0Less65535Exclsv
          PagesToSkip    : IntMore0Less65535Exclsv
          PagesToSkipMax : IntMore0Less65535Exclsv

          TotalNumberOfItemsInDB : uint32
          LeftIndexInclsv        : uint32
          RightIndexInclsv       : uint32

          IsValidLeft      : bool
          IsValidLeftMore  : bool
          IsValidRight     : bool
          IsValidRightMore : bool}
